using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    class _newarray_newarray_
    {
        [OuterLoop]
        [Fact]
        public void _newarray_newarray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("readytorun\\tests\\newarray\\newarray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
