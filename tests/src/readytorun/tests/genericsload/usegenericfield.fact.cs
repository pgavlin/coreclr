using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    class _genericsload_usegenericfield_usegenericfield_
    {
        [OuterLoop]
        [Fact]
        public void _genericsload_usegenericfield_usegenericfield_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("readytorun\\tests\\genericsload\\usegenericfield\\usegenericfield.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
