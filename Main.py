# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 16 June 2017
# Description: Main file for Single Locus Sequence Typing (SLST)


from Slicer import create_fasta
from Concatenator import concat

genome = 'ATGGTAGTAGCATATCAAAAGGGGTTTCC'

create_fasta(genome, size=6)

fragA = {'strain7':'AT', 'strain9':'ATC'}
fragB = {'strain7':'TTT', 'strain9':'TTA'}
d = concat([fragA, fragB])

print d
