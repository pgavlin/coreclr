using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_constructor_r_constructor_r_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_constructor_r_constructor_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\constructor_r\\constructor_r.cmd");
        }
    }
}
