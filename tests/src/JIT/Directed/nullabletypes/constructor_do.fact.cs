using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_constructor_do_constructor_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_constructor_do_constructor_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\constructor_do\\constructor_do.cmd");
        }
    }
}
