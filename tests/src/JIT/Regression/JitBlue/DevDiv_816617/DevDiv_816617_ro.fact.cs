using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _JitBlue_DevDiv_816617_DevDiv_816617_ro_DevDiv_816617_ro_
    {
        [OuterLoop]
        [Fact]
        public void _JitBlue_DevDiv_816617_DevDiv_816617_ro_DevDiv_816617_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\DevDiv_816617\\DevDiv_816617_ro\\DevDiv_816617_ro.cmd");
        }
    }
}
