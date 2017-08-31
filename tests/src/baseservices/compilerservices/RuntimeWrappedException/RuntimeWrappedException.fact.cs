using CoreclrTestLib;
using Xunit;

namespace baseservices_compilerservices
{
    class _RuntimeWrappedException_RuntimeWrappedException_RuntimeWrappedException_
    {
        [Fact]
        public void _RuntimeWrappedException_RuntimeWrappedException_RuntimeWrappedException_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\compilerservices\\RuntimeWrappedException\\RuntimeWrappedException\\RuntimeWrappedException.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
