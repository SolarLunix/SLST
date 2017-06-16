# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 16 June 2017
# Description: Created the individual slices and will eventually store them in a multi-FASTA-file for later use.


def seq_slice(sequence, size=200):
    start = 0
    end = size
    while len(sequence) >= end:
        yield sequence[start:end]
        start += size
        end += size

