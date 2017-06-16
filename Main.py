

def slice(sequence, size=200):
    start = 0
    end = size
    while len(sequence) >= end:
        yield sequence[start:end]
        start += size
        end += size


genome = 'ATGGTAGTAGCATATCAAAAGGGGTTTCC'

sequence = slice(genome, size=6)

for seq in sequence:
    print seq

print "End 1"

for seq in sequence:
    print seq

print "End 2"
