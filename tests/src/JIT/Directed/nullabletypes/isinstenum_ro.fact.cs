using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_isinstenum_ro_isinstenum_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_isinstenum_ro_isinstenum_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\isinstenum_ro\\isinstenum_ro.cmd");
        }
    }
}
