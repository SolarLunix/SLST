# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 16 June 2017
# Description: Main file for Single Locus Sequence Typing (SLST)


from Slicer import create_fasta, read_fas
from Concatenator import concatenator as concat

genome = 'ATGGTAGTAGCATATCAAAAGGGGTTTCC'

create_fasta(genome, size=6)
gen1, des1 = read_fas("inputs/KPA171202.fasta")
gen2, des2 = read_fas("inputs/SK137.fasta")
gen3, des3 = read_fas()

create_fasta(gen1['NC_006085.1'], 200, 200, "outputs/KPAfrags.fasta")

fragA = {'strain7':'AT', 'strain9':'ATC'}
fragB = {'strain7':'TTT', 'strain9':'TTA'}
d = concat([fragA, fragB])

print d
