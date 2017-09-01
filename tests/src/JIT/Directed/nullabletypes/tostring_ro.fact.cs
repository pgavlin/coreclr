using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _nullabletypes_tostring_ro_tostring_ro_
    {
        [OuterLoop]
        [Fact]
        public void _nullabletypes_tostring_ro_tostring_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\nullabletypes\\tostring_ro\\tostring_ro.cmd");
        }
    }
}
