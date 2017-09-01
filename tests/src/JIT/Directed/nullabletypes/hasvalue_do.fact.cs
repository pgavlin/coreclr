using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_hasvalue_do_hasvalue_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_hasvalue_do_hasvalue_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\hasvalue_do\\hasvalue_do.cmd");
        }
    }
}
