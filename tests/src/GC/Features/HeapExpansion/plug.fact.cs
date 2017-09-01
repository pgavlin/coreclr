using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _HeapExpansion_plug_plug_
    {
        [Fact]
        public void _HeapExpansion_plug_plug_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\HeapExpansion\\plug\\plug.cmd");
        }
    }
}
