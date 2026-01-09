class HelloWorld {
    static Main(args) {
        var obj = new ProblemSolution();
        
        var arr = [321, 12, 4, 12, 41];
        
        obj.SortColor(arr);
        
        console.log(arr.join(" -> "));
    }
}

class ProblemSolution {
    SortColor(nums) {
        while (!this.ChechArrNotINF(nums)) {
            for (var i = 0; i < nums.length; i++) {
                if (i + 1 < nums.length && nums[i] > nums[i + 1]) {
                    [nums[i], nums[i + 1]] = [nums[i + 1], nums[i]];
                }
            }
        }
    }

    ChechArrNotINF(nums) {
        var resul = true;
        
        for (var i = 0; i < nums.length; i++) {
            if (i + 1 < nums.length && nums[i] > nums[i + 1]) {
                resul = false;
            }
        }
        
        return resul;
    }
}

// Program start
HelloWorld.Main([]);
