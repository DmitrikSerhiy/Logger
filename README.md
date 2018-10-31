# Logger
## Architecture changes

* I did not used WriterPool as I don't see any worthy reason for it
* Added IBatchLogger (just for comfortable resolving from container)
* Changed (Debug(), Info(), Warn()... methods') return type from void to ILoggerMessage (it's more sutable for buffering). Thus, there is no reason to use GetLoggerMessage() and WriteLog() methods from LoggerBase. (I thought that these method are quite redundant, but I haven't removed them yet)
* Added BufferMessage, IBufferMessage and CustomeBuffer classes.
* What I didn't understand is the reason for Write(Ienumerable<ILoggerMessage> messages) method. (How should it has to be used?)
