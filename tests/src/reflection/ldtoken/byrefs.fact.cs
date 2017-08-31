using CoreclrTestLib;
using Xunit;

namespace reflection_ldtoken
{
    class _byrefs_byrefs_
    {
        [OuterLoop]
        [Fact]
        public void _byrefs_byrefs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("reflection\\ldtoken\\byrefs\\byrefs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
