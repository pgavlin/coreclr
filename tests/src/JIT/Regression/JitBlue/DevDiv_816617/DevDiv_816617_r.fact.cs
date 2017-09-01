using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_816617_DevDiv_816617_r_DevDiv_816617_r_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_816617_DevDiv_816617_r_DevDiv_816617_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_816617\\DevDiv_816617_r\\DevDiv_816617_r.cmd");
        }
    }
}
