using CoreclrTestLib;
using Xunit;

namespace Loader_regressions
{
    class _polyrec_Polyrec_Polyrec_
    {
        [OuterLoop]
        [Fact]
        public void _polyrec_Polyrec_Polyrec_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\regressions\\polyrec\\Polyrec\\Polyrec.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
