using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_constructor_ro_constructor_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_constructor_ro_constructor_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\constructor_ro\\constructor_ro.cmd");
        }
    }
}
