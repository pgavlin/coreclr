using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_tostring_do_tostring_do_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_tostring_do_tostring_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\tostring_do\\tostring_do.cmd");
        }
    }
}
