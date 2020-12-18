import itertools

import numpy


def findId(ticked_code):
    binary_row = [64, 32, 16, 8, 4, 2, 1]
    binary_place = [4, 2, 1]
    row = 0
    place = 0

    row_code = ticked_code[0:7]
    place_code = ticked_code[7:len(ticked_code)]

    for i in range(0, len(row_code)):
        if row_code[i] == 'B':
            row += binary_row[i]

    for i in range(0, len(place_code)):
        if place_code[i] == 'R':
            place += binary_place[i]

    ticket_id = row * 8 + place

    return ticket_id


def read_file():
    with open("input.txt", "r") as ins:
        array = []
        for line in ins:
            array.append(line.replace("\n", ""))
    return array


def gen_all_ticked_ids():
    row = [list(i) for i in itertools.product(['F', 'B'], repeat=7)]
    row.remove(['F', 'F', 'F', 'F', 'F', 'F', 'F'])
    row.remove(['B', 'B', 'B', 'B', 'B', 'B', 'B'])
    row_str = ["".join(a) for a in row]

    place = [list(i) for i in itertools.product(['L', 'R'], repeat=3)]
    place_str = ["".join(a) for a in place]

    all_comb = [list(i) for i in itertools.product(row_str, place_str)]
    all_str = ["".join(a) for a in all_comb]

    all_id = [findId(all_code) for all_code in all_str]

    return all_id


if __name__ == '__main__':
    id_array = []
    free_id_array = []

    text_read_array = read_file()

    for code in text_read_array:
        id_array.append(findId(code))

    print("")
    print(f'Max ID: {numpy.max(id_array)}')

    print("")
    free_place_ids = gen_all_ticked_ids()
    print(len(free_place_ids) - len(id_array))

    id_array.sort()
    mySeat = id_array[0]

    for x in range(0, len(id_array)):
        if mySeat is not id_array[x]:
            print(f'Freier Platz: {mySeat}')
            break
        mySeat += 1

