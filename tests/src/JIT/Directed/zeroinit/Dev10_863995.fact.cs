using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _zeroinit_Dev10_863995_Dev10_863995_
    {
        [Fact]
        public void _zeroinit_Dev10_863995_Dev10_863995_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\Dev10_863995\\Dev10_863995.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
