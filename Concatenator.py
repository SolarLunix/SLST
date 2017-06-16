# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 16 June 2017
# Description: Putting the genomic sequence back together from the fragments.


def concat(fragments):
    out = {}
    count = 0
    for frag in fragments:
        for f in frag:
            try:
                out[f] += frag[f]
            except KeyError:
                out[f] = count*'-' + frag[f]
        count = max([len(out[i]) for i in out])
        for n in out:
            while len(out[n]) < count:
                out[n] += '-'

    return out
