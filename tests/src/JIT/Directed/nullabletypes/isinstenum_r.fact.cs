using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstenum_r_isinstenum_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstenum_r_isinstenum_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstenum_r\\isinstenum_r.cmd");
        }
    }
}
