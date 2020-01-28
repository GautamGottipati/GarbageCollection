## This project contains:

* Idisposable<br>
IDisposable is an interface that contains a single method, Dispose(), for releasing unmanaged resources, like files, streams, database connections and so on.
This method is implemented explicitly in the code when we need to clean up a disposable object and to release unmanaged resources that this disposable object holds.

* Using<br>
The "using" statement allows you to specify multiple resources in a single statement. The object could also be created outside the "using" statement. The objects specified within the using block must implement the IDisposable interface. The framework invokes the Dispose method of objects specified within the "using" statement when the block is exited. 


