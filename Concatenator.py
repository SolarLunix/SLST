# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 18 June 2017
# Description: Putting the genomic sequence back together from the fragments.


def concat(fragments):
    out = {}
    count = 0
    for frag in fragments:
        # for each dictionary passed in look at the keys in the dictionary
        for f in frag:
            # for each key in the dictionary take the value for the key and add it to the same key in the output
            try:
                out[f] += frag[f]
            except KeyError:
                # if the key doesn't exist, create it.
                out[f] = count*'-' + frag[f]
        # make sure all the fragments line up to be the same size and add - where they don't.
        count = max([len(out[i]) for i in out])
        for n in out:
            while len(out[n]) < count:
                out[n] += '-'

    return out
