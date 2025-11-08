class Solution:
    def validMountainArray(self, arr):
        if len(arr) < 3:
            return False

        if arr[1] < arr[0]:
            return False

        prev = arr[0]
        asc = True
        desc = False
        for i in range(1, len(arr)):
            if prev == arr[i]:
                return False

            if asc:
                if prev > arr[i]:
                    asc = False
                    desc = True

            else:
                if prev < arr[i]:
                    return False

            prev = arr[i]
        
        return not asc and desc
