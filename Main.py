# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 16 June 2017
# Description: Main file for Single Locus Sequence Typing (SLST)


from Slicer import seq_slice

genome = 'ATGGTAGTAGCATATCAAAAGGGGTTTCC'

sequence = seq_slice(genome, size=6)

for seq in sequence:
    print seq
