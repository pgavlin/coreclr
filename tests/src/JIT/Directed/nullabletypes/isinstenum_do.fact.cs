using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstenum_do_isinstenum_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstenum_do_isinstenum_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstenum_do\\isinstenum_do.cmd");
        }
    }
}
