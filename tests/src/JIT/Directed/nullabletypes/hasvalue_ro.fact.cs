using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_hasvalue_ro_hasvalue_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_hasvalue_ro_hasvalue_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hasvalue_ro\\hasvalue_ro.cmd");
        }
    }
}
