import json
import random

if __name__ == '__main__':
    colors = ["blue", "red", "yellow", "green"]
    size = ["small", "medium", "large"]
    for i in range(4):
        for j in range(3):
            if i == 0:
                task_type = "click"
                goal = -1
                start = 0
                num_dots = 1
            elif i == 1:
                task_type = "drag"
                goal = 1
                start = 0
                num_dots = 2
            elif i == 2:
                task_type = "pan"
                goal = 1
                num_dots = 2
            elif i == 3:
                task_type = "zoom"
                goal = -1
                start = 0
                num_dots = 1

            test = {
                "task": task_type,
                "size": random.choice(size),
                "color": random.choice(colors),
                "locations":
                    [],
                "start": start,
                "goal": goal,
            }

            for k in range(num_dots):
                test["locations"].append([random.randrange(-4, 4), random.randrange(-3, 3)])

            json_object = json.dumps(test, indent=None) # , indent=4
            with open(f"tasks/test_{task_type}{j}", "w") as f:
                f.write(json_object)

# {
#   "task": "click",
#   "size": 5,
#   "color": "yellow",
#   "locations":  [
#     [
#       [-122.4194, 37.7749]
#     ],
#   "start": 0,
#   "goal": -1
# }
