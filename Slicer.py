# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 16 June 2017
# Description: Created the individual slices and will eventually store them in a multi-FASTA-file for later use.


def seq_slice(sequence, size):
    start = 0
    end = size
    while len(sequence) >= end:
        yield sequence[start:end]
        start += size
        end += size


def create_fasta(sequence, size=200, file_name="outputs/strain.txt", seq_id="seq"):
    sliced = seq_slice(sequence, size)
    f = open(file_name, "w")
    count = 0
    start = 0
    end = size - 1
    for seq in sliced:
        sequence_id = ">" + seq_id + "_" + str(count)
        des = "Data from position " + str(start) + " to " + str(end)
        line = sequence_id + " " + des + "\n"
        f.write(line)
        line = seq + "\n"
        f.write(line)

        start += size
        end += size
        count += 1
    print "FASTA created"
