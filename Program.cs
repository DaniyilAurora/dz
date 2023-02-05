using VpuDotNet2.Models;

IMovable[] movables = new IMovable[] {
    new Human {
        Speed = 10
    },
    new Car {
        Speed = 15
    },
    new Human {
        Speed = 25
    },
    new Car {
        Speed = 39
    },
    new Human {
        Speed = 75
    },
    new Car {
        Speed = 2
    }
};

foreach (IMovable movable in movables) 
{
    if (movable is Human human) {
        human.Move();
    }
}