using CoreclrTestLib;
using Xunit;

namespace Interop_SimpleStruct
{
    public class _SimpleStruct_SimpleStruct_
    {
        [OuterLoop]
        [Fact]
        public void _SimpleStruct_SimpleStruct_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\SimpleStruct\\SimpleStruct\\SimpleStruct.cmd");
        }
    }
}
