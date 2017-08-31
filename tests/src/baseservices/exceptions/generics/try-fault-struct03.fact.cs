using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_try_fault_struct03_try_fault_struct03_
    {
        [OuterLoop]
        [Fact]
        public void _generics_try_fault_struct03_try_fault_struct03_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\try-fault-struct03\\try-fault-struct03.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
