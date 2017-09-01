using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_206786_handleMath_handleMath_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_206786_handleMath_handleMath_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_206786\\handleMath\\handleMath.cmd");
        }
    }
}
