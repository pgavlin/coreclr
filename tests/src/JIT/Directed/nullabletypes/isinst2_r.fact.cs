using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinst2_r_isinst2_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinst2_r_isinst2_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinst2_r\\isinst2_r.cmd");
        }
    }
}
