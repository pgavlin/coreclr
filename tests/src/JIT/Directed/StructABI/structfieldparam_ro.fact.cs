using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _StructABI_structfieldparam_ro_structfieldparam_ro_
    {
        [OuterLoop]
        [Fact]
        public void _StructABI_structfieldparam_ro_structfieldparam_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\StructABI\\structfieldparam_ro\\structfieldparam_ro.cmd");
        }
    }
}
