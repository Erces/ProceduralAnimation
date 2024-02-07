using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.Mathematics;
public class SpiderAnimator : MonoBehaviour
{
    
    [SerializeField] private bool isRightLegHigher;
    [Header("Transforms")]
    [SerializeField] private List<Transform> rightLegs;
    [SerializeField] private Transform rightFrontLeg;
    [SerializeField] private Transform rightBackLeg;
    [SerializeField] private Transform leftFrontLeg;
    [SerializeField] private Transform leftBackLeg;
    [Space(2)]
    [SerializeField] private List<Transform> leftLegs;
    [SerializeField] private List<Transform> legs;
    [Space(2)]
    [SerializeField] private Transform rightTrack;
    [SerializeField] private Transform rightBackTrack;
    [SerializeField] private Transform leftTrack;
    [SerializeField] private Transform leftBackTrack;
    [Header("Floats")]
    [SerializeField] private float maxLegHeight;
    [SerializeField] private float minLegHeight;
    [SerializeField] private float legHeightDifference;
    [SerializeField] private float trackRange;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveZ(transform.position.z + 15,14);
    }

    // Update is called once per frame
    void Update()
    {
        HandleRightLegs();
        HandleLeftLegs();
        LegDifference();
        RotateBody();
    }
    void LegDifference(){
        var maxLegHeight = 0f;
        var minLegHeight = Mathf.Infinity;
        foreach (var item in legs)
        {
            if(item.position.y < minLegHeight){
                minLegHeight = item.position.y;
            }
            if(item.position.y > maxLegHeight){
                
                maxLegHeight = item.position.y;
                if(item.transform.name.StartsWith("R")){
                    isRightLegHigher = true;
                }
                else{
                    isRightLegHigher = false;
                }
            }
        }
        legHeightDifference = maxLegHeight - minLegHeight;
    }
    void RotateBody(){
        if(isRightLegHigher){
        this.transform.rotation = Quaternion.Euler(0,0,legHeightDifference* 45);

        }
        else{
        this.transform.rotation = Quaternion.Euler(0,0,-legHeightDifference* 45);
        }
    }
    void HandleRightLegs(){
        if(Mathf.Abs(Vector3.Distance(rightFrontLeg.position,rightTrack.position)) > trackRange){
            rightFrontLeg.transform.DOMove(rightTrack.position,.2f);
        }
        if(Mathf.Abs(Vector3.Distance(rightBackLeg.position,rightBackTrack.position)) > trackRange){
            rightBackLeg.transform.DOMove(rightBackTrack.position,.2f);
        }
    }
    void HandleLeftLegs(){
        if(Mathf.Abs(Vector3.Distance(leftFrontLeg.position,leftTrack.position)) > trackRange){
            leftFrontLeg.transform.DOMove(leftTrack.position,.2f);
        }
        if(Mathf.Abs(Vector3.Distance(leftBackLeg.position,leftBackTrack.position)) > trackRange){
            leftBackLeg.transform.DOMove(leftBackTrack.position,.2f);
        }
    }
}
