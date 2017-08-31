using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_GenericExceptions04_GenericExceptions04_
    {
        [OuterLoop]
        [Fact]
        public void _generics_GenericExceptions04_GenericExceptions04_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\GenericExceptions04\\GenericExceptions04.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
