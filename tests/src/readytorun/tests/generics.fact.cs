using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    class _generics_generics_
    {
        [OuterLoop]
        [Fact]
        public void _generics_generics_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("readytorun\\tests\\generics\\generics.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
