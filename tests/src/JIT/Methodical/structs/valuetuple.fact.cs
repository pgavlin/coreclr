using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _structs_valuetuple_valuetuple_
    {
        [OuterLoop]
        [Fact]
        public void _structs_valuetuple_valuetuple_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\structs\\valuetuple\\valuetuple.cmd");
        }
    }
}
