using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _semaphore_unit_semdemo_semdemo_
    {
        [OuterLoop]
        [Fact]
        public void _semaphore_unit_semdemo_semdemo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\unit\\semdemo\\semdemo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
