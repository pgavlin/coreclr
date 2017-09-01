using CoreclrTestLib;
using Xunit;

namespace JIT_opt
{
    public class _FastTailCall_StructPassingSimple_StructPassingSimple_
    {
        [Fact]
        public void _FastTailCall_StructPassingSimple_StructPassingSimple_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\opt\\FastTailCall\\StructPassingSimple\\StructPassingSimple.cmd");
        }
    }
}
