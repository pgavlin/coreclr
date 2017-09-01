using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_External_dev11_91048_UseTrashedVfp1_UseTrashedVfp1_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_91048_UseTrashedVfp1_UseTrashedVfp1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_91048\\UseTrashedVfp1\\UseTrashedVfp1.cmd");
        }
    }
}
