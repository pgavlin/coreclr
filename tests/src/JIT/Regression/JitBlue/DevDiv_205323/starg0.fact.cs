using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_205323_starg0_starg0_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_205323_starg0_starg0_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_205323\\starg0\\starg0.cmd");
        }
    }
}
