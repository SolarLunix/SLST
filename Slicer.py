# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 21 June 2017
# Description: Created the individual slices and will eventually store them in a multi-FASTA-file for later use.


def seq_slice(sequence, size, jump):
    # Splits the sequence into fragments of size size and returns them through the yeild
    start = 0
    end = size
    while len(sequence) >= end:
        yield sequence[start:end]
        start += jump
        end += jump
    """
        I would like to make an adjustment here at a later date that makes sure that the last peice of the sequence is
        also output and then put into the FASTA sheet with the correct description. For the moment this is not needed to
        replicate what is being done in the paper.
    """


def create_fasta(sequence, size=200, jump=200, file_name="strain.fasta", seq_id="seq"):
    # Creates a FASTA-file from the genomic data provided, sending it through the seq_slice method to split it before
    # saving it to a file of file_name using sequence id's of seq_id

    print "Creating Fasta"
    file_name = "files/" + file_name

    sliced = seq_slice(sequence, size, jump)
    f = open(file_name, "w")
    count = 0
    start = 0
    end = size - 1

    # Goes through each slice returned from the seq_slice method and saves it to a file
    for seq in sliced:
        # Create the sequence id and description for each slice
        sequence_id = ">" + seq_id + "_" + str(count)
        des = "frag_" + str(count) + "Data from position " + str(start) + " to " + str(end)
        line = sequence_id + " " + des + "\n"

        # Write the sequence id and description to the file
        f.write(line)

        # Write the sequence to the file followed by a new line
        line = seq + "\n"
        f.write(line)

        # Progress the start, end, and count for the sequence_id and description.
        start += jump
        end += jump
        count += 1

    print "FASTA created -", file_name


def read_fas(file_loc="strain.fasta"):
    # This method will read in the fas file or files for processing. For ease of use put the files in the inputs folder
    file_loc = "files/" + file_loc
    print "Reading from:", file_loc
    a_file = open(file_loc)
    document = a_file.readlines()
    descriptions = {}
    genetics = {}
    last_read = ""
    key = ""

    for line in document:
        fixed = line.replace("\n", "")

        if fixed.__contains__(">"):
            # Create the key, and put the full description of the key in the descriptions dict.
            end = fixed.find(" ")
            key = fixed[1:end]
            descriptions[key] = fixed
            last_read = ""
        else:
            last_read += fixed
            genetics[key] = last_read

    print "Returning read file and descriptions"
    return genetics, descriptions