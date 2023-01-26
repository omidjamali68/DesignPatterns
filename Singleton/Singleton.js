class Process {
    constructor(state) {
        this.state = state;
    }
}

const Singleton = (function () {
    function CreateProcessInstance() {
        return new Process();
    };

    let instance;

    return {
        GetProcess() {
            if (!instance)
                instance = CreateProcessInstance();

            return instance;
        }
    };
})();

const process1 = Singleton.GetProcess();
const process2 = Singleton.GetProcess();

console.log(process1 == process2);  // return true