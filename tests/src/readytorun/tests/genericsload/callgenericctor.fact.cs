using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    class _genericsload_callgenericctor_callgenericctor_
    {
        [OuterLoop]
        [Fact]
        public void _genericsload_callgenericctor_callgenericctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("readytorun\\tests\\genericsload\\callgenericctor\\callgenericctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
