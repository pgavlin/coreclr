using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_815940_DevDiv_815940_ro_DevDiv_815940_ro_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_815940_DevDiv_815940_ro_DevDiv_815940_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_815940\\DevDiv_815940_ro\\DevDiv_815940_ro.cmd");
        }
    }
}
