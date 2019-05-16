from __future__ import print_function

import os
import sys

from os import listdir, walk, system
from os.path import isfile, join, realpath, dirname

from tqdm import tqdm

from core import *


class Files:
    total = []

    def __init__(self) -> None:
        self.current_directory = dirname(realpath(__file__))
        self.is_python_idle = sys.stdin.isatty()

    def save_files(self, output_errors: bool = False, output_location: str = "data/file_list.list") -> "Files":
        output_location = output_location.replace("/", "\\")
        if (output_location[1] != ":"):  # Make sure the beginning of the directory is a drive, such as C:
            output_location = os.path.join(self.current_directory, output_location)
        output_directory = os.path.split(output_location)[0]
        if not os.path.exists(output_directory):
            os.makedirs(output_directory)
        with open(output_location, "w+") as f:
            for file in self.total:
                try:
                    f.write("{}\n".format(file))
                except Exception as e:
                    if (output_errors):
                        print(e)
        return self

    def get_files(self, directory: str) -> list:
        # Todo: Maybe check if the beginning of the directory is a location?
        files_found = list()
        temp_files = [f for f in listdir(directory) if isfile(join(directory, f))]
        for temp_file in temp_files:
            final_file = directory + "/" + temp_file
            files_found.append(final_file)
        return files_found

    def main(self, directory: str = None) -> "Files":
        if not directory:
            directory = self.current_directory
        if not self.is_python_idle:
            system("cls")
            print("{} Gathering FileSystem Directories from {}...".format(colors.c_green, directory))
            directories = list()
            for file_name in walk(directory):
                directories.append(file_name[0])
                print("Gathered Directory: {}{}{}".format(colors.c_white, file_name[0], colors.c_green))
            print("{} Gathering files in {} {} {} directories.. {}".format(colors.c_white,
                                                                           colors.c_blue,
                                                                           len(directories),
                                                                           colors.c_white,
                                                                           colors.c_blue))
            progress_bar = tqdm(total=len(directories))
            for directory in directories:
                directory = directory.replace("\\", "/")
                self.total = self.get_files(directory)
                progress_bar.update(1)
        return self


if __name__ == "__main__":
    files = Files()
    files.main()
    files.save_files()
