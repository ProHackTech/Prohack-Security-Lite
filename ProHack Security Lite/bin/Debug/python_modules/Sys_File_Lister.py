from __future__ import print_function
from os import listdir, walk, system
from os.path import isfile, join, realpath, dirname
from tqdm import tqdm

# import terminal beauty
from core.colors import c_white, c_green, c_red, c_yellow, c_blue

# saving all the gathered filepaths into list
total_files = []

curpath = dirname(realpath(__file__)) # get the folder in which the current python script is located

# save the list into file
def save_files(filelist):
	filepath = curpath + "/data/File_List.list" # make the file path for file name to save
	with open(filepath, 'w') as f: # open file
		for file in total_files: # for each item in total_items list
			try: # try (addded becasue some file paths have codec issue, so we ignore them)
				f.write(f"{file}\n") # write into file and add newline
			except: # if error
				pass # pass/continues

# get the files from folder ( didn't want to make a recurrsive function right now :/ )
def get_files(dir):
	tempfiles = [f for f in listdir(dir) if isfile(join(dir, f))] # list comprehension
	for temp_file in tempfiles: # for each item in tempfiles list
		finalfile = dir + "/" + temp_file # generate the file name
		total_files.append(finalfile) # append into list

# starting function
def init(init_dir):
	system('cls') # clear screen (windows specific)
	print(f"{c_green} Gathering FileSystem Directories from {init_dir}..")
	dirs = [] # initialize the list
	for x in walk(init_dir):
		dirs.append(x[0])
		print(f"Gathered Directory: {c_white}{x[0]}{c_green}")
	print(f"{c_white} Gathering files in {c_blue} {len(dirs)} {c_white} directories.. {c_blue}")
	pbar = tqdm(total=len(dirs)) # initialize the progressbar
	for dir in dirs: # for each directory in list of directories
		dir = dir.replace("\\", "/")
		get_files(dir) # start the get files function
		pbar.update(1) # update the progressbar
	print(f"{c_blue} Saving file list...{c_white}")
	# start the save file function
	save_files(total_files)


# check the list_from configuration
list_conf_path = "list_from.txt"
list_conf = ""
if isfile(list_conf_path):
	with open(list_conf_path, 'r') as f:
		list_conf = f.readline().strip()
	print(list_conf)
	if list_conf == "quick":
		init("C:/Program Files/")
	elif list_conf == "deep":
		init("C:/")
else:
	init("C:/")
