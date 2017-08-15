# Created by: Melissa Melaugh
# Date Created: 16 June 2017
# Date Edited: 19 June 2017
# Description: Putting the genomic sequence back together from the fragments.


def concatenator(fragments):
    out = {}
    count = 0
    for frag in fragments:
        # for each dictionary passed in look at the keys in the dictionary
        for strain in frag:
            # for each key in the dictionary take the value for the key and add it to the same key in the output
            try:
                out[strain] += frag[strain]
            except KeyError:
                # if the key doesn't exist, create it.
                out[strain] = count*'-' + frag[strain]
        # make sure all the fragments line up to be the same size and add - where they don't.
        count = max([len(out[i]) for i in out])
        for strain in out:
            while len(out[strain]) < count:
                out[strain] += '-'

    return out
