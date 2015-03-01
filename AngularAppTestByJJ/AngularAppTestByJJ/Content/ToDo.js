function TodoCtrl($scope) {


    $scope.todos = [{ text: 'Jasper AngularJS', done: false }, { text: "Test2", done: false }];

    $scope.getTotalTodos = function () {
        return $scope.todos.length;
    };

    $scope.test = function () {
   
        var oldToDos = $scope.todos;
        $scope.todos = [];
        angular.forEach(oldToDos, function(todo){
            if (!todo.done) $scope.todos.push(todo);
        })
    };

    $scope.addToDo = function () {
        $scope.todos.push({ text: $scope.formTodoText, done: false });
        $scope.formTodoText = "";
    };

   
};

