using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_hasvalue_r_hasvalue_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_hasvalue_r_hasvalue_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hasvalue_r\\hasvalue_r.cmd");
        }
    }
}
