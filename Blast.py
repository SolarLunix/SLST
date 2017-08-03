# Created by: Melissa Melaugh
# Date Created: 02 August 2017
# Date Edited: 03 August 2017
# Description: File for blasting the sequence and then running it through MEGA

import os

from subprocess import check_output


def blast_extract(frag_path, genome_path):
    path = os.path.dirname(os.path.realpath("files"))
    frag_path_full = path + "\\files\\" + frag_path
    genome_path_full = path + "\\files\\" + genome_path

    print "Fragments:", frag_path
    print "Genome:", genome_path

    cmd = 'blastn -query "' + frag_path_full + '" -outfmt "6 std" -subject "' + genome_path_full + '"'
    p = check_output(cmd, shell="True").decode('ascii')

    result = "files/" + frag_path + "_" + genome_path + "_blast_result.xls"
    result = result.replace(".fasta", "")
    f = open(result, "w")

    hit_list = result.replace(".xls", ".txt")
    f2 = open(hit_list, "w")

    last_hit = 'none'
    top = "qseqid \tsseqid \tpident \tlength \tmismatch \tgapopen \tqstart \tqend \tsstart \tsend \tevalue \tbitscore"
    f.write(top)
    for hit in p.split('\n'):
        value = hit.split('\t')
        if len(value) > 1 and value[0] != last_hit:
            f.write(hit)
            f2.write(('Candidate %s found in %s between nt %s and %s' %(value[0], value[1], value[8], value[9])))
            last_hit = value[0]

    f.close()
