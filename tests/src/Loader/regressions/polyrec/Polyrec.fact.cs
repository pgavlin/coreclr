using CoreclrTestLib;
using Xunit;

namespace Loader_regressions
{
    public class _polyrec_Polyrec_Polyrec_
    {
        [OuterLoop]
        [Fact]
        public void _polyrec_Polyrec_Polyrec_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\regressions\\polyrec\\Polyrec\\Polyrec.cmd");
        }
    }
}
