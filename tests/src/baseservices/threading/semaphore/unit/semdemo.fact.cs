using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _semaphore_unit_semdemo_semdemo_
    {
        [OuterLoop]
        [Fact]
        public void _semaphore_unit_semdemo_semdemo_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\semaphore\\unit\\semdemo\\semdemo.cmd");
        }
    }
}
