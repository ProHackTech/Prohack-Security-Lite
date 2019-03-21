import argparse
from tqdm import tqdm
from selenium import webdriver
from selenium.webdriver.firefox.options import Options

temp_extensions = []

def file_saver(filepath):
	with open(filepath, 'w') as f:
		f.writelines("%s\n" % extensions for extensions in temp_extensions)

def download_list(url, filepath):
	print("Please Wait.. Updating List")
	options = Options()
	options.headless = True
	driver = webdriver.Firefox(options=options, executable_path="geckodriver.exe")
	driver.get(url)

	# td rows
	tdrows = driver.find_elements_by_class_name("sorting_1")
	numRows = len(tdrows)
	pbar = tqdm(total=numRows)
	for row in tdrows:
		link = row.find_element_by_tag_name("a")
		temp_extensions.append(link.text)
		pbar.update(1)
	driver.quit()
	pbar.close()
	file_saver(filepath)

def manager(type):
	temp_name = ""
	temp_filepath = ""
	temp_url = ""

	# read filetype list and process
	with open("extension_types.txt") as f:
		for line in f:
			strings = line.split(" || ")
			temp_name = strings[0]
			if type == temp_name:
				temp_filepath = strings[1]
				temp_url = strings[2]

	# remove \n from temp_url
	temp_url.rstrip()

	# start downloader
	download_list(temp_url, temp_filepath)

def init():
	parser = argparse.ArgumentParser(description='Update Extension Lists')
	parser.add_argument('--type', '-type', type=str, help='List type to update')
	args = parser.parse_args()

	manager(args.type)

if __name__ == "__main__":
	init()