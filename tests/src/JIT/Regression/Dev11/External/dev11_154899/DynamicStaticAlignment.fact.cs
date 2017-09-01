using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_External_dev11_154899_DynamicStaticAlignment_DynamicStaticAlignment_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_154899_DynamicStaticAlignment_DynamicStaticAlignment_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_154899\\DynamicStaticAlignment\\DynamicStaticAlignment.cmd");
        }
    }
}
