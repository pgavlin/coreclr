using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_fault_struct01_try_fault_struct01_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_fault_struct01_try_fault_struct01_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-fault-struct01\\try-fault-struct01.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
