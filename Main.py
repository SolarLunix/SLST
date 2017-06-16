# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 16 June 2017
# Description: Main file for Single Locus Sequence Typing (SLST)


from Slicer import create_fasta

genome = 'ATGGTAGTAGCATATCAAAAGGGGTTTCC'

create_fasta(genome, size=6)
